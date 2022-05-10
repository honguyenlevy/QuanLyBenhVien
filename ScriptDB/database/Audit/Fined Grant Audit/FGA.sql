--•	Audit vi?c thêm, xóa s?a trên b?ng HSBA v?i nh?ng h? s? có chuyên khoa là khoa ngo?i 
BEGIN
  DBMS_FGA.add_policy(
    object_schema   => 'QTV',
    object_name     => 'HSBA',
    policy_name     => 'HSBA_FGA_AUDIT',
    audit_condition => 'MAKHOA = ''NGOAI''', 
    audit_column    => 'CHUANDOAN,MAKHOA,MACSYT',
    statement_types => 'INSERT,UPDATE,DELETE');
END;

/*BEGIN
  DBMS_FGA.drop_policy(
    object_schema   => 'QTV',
    object_name     => 'HSBA',
    policy_name     => 'HSBA_FGA_AUDIT');
END; */
   
--•	Audit vi?c thêm, xóa, s?a trên b?ng nhân viên v?i các nhân viên có VAI TRO LA THANH TRA   

   BEGIN
  DBMS_FGA.add_policy(
    object_schema   => 'QTV',
    object_name     => 'NHANVIEN',
    policy_name     => 'NHANVIEN_FGA_AUDIT',
    audit_condition => 'VAITRO = ''THANH TRA''', 
    audit_column    => 'CSYT,VAITRO,CHUYENKHOA',
    statement_types => 'SELECT,INSERT,UPDATE,DELETE');
END;
   
   
 /*BEGIN
  DBMS_FGA.drop_policy(
    object_schema   => 'QTV',
    object_name     => 'NHANVIEN',
    policy_name     => 'NHANVIEN_FGA_AUDIT');
END; */

   SELECT DB_USER,OBJECT_NAME,SQL_TEXT,EXTENDED_TIMESTAMP FROM dba_fga_audit_trail order by extended_timestamp desc;
   