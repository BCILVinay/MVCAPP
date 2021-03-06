
ALTER PROC [dbo].[USP_SendMailConfiguration]
@Recipients varchar(max)=null,
@SUBJECT varchar(max)=null,
@BODY varchar(max)=null,
@CCRecipients varchar(max)=null
AS
 BeGIN

 DECLARE @mail_id int =0 ;
 BEGIN TRY	
  EXEC msdb.dbo.sp_send_dbmail  
    @profile_name = 'DBA',  
    @recipients = @Recipients,  
	@copy_recipients=@CCRecipients,
    @body = @BODY,  
	@body_format ='HTML',
    @subject = @SUBJECT,
	@mailitem_id =@mail_id output ;
 
 SELECT
    CASE sent_status
        WHEN 0 THEN 'Unsent'
        WHEN 1 THEN 'Sent'
        WHEN 2 THEN 'Failed'
        WHEN 3 THEN 'Retrying'
        END AS sent_status_desc
FROM msdb..sysmail_mailitems WHERE mailitem_id = @mail_id;
END TRY
BEGIN CATCH
END CATCH
END  
