alter system set audit_trail='db','extended' scope=spfile;

--•	Audit vi?c thêm, xóa, c?p nh?t d? li?u b?ng CSYT c?a DBA 
audit insert, delete, update on QTV.CSYT by access;

--noaudit all on qtv.CSYT;

--•	Audit vi?c thêm xóa, c?p nh?ta d? li?u cho b?ng nhân viên 
audit insert,delete, update on QTV.NHANVIEN by access;
--noaudit all on qtv.NHANVIEN;

--•	Audit vi?c th?c thi procedure themHSBA 
AUDIT EXECUTE ON THEMHSBA BY ACCESS;

--noaudit all on qtv.THEMHSBA;

--•	Audit vi?c xem, thêm, xóa, s?a c?a b?ng khóa ng??i dùng UK
AUDIT INSERT,UPDATE,DELETE ON QTV.UKNHANVIEN;

--noaudit all on qtv.UKNHANVIEN;

AUDIT INSERT,UPDATE,DELETE ON QTV.UKHSBA;
--noaudit all on qtv.UKHSBA;

select USERNAME,OBJ_NAME,SQL_TEXT ,EXTENDED_TIMESTAMP
from dba_audit_trail order by extended_timestamp;


TRUNCATE TABLE SYS.AUD$;


alter system set audit_trail='db','extended' scope=spfile;


UPDATE QTV.NHANVIEN SET VAITRO='THANH TRA'
SELECT * FROM QTV.NHANVIEN;
COMMIT;

