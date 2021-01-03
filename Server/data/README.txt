README.TXT
------------------
File config: Server.exe.config
------------------
Hướng dẫn tạo Database:
- Cách 1: 
	+ Bước 1: Tìm đến nơi cài ứng dụng và copy đường dẫn của thư mục data. 
		Để tìm ứng dụng nhấn phải chuột vào icon -> Properties -> Shortcut -> Open File Location
	+ Bước 2: Edit file CreateDatabase.bat 
		sqlcmd -S <Tên server> -i "<Đường dẫn tới thu mục data copy bước trước>\data.sql" -U <User Id> -P <Password>
	*Lưu ý: Nếu Server không có UserName và Password thì xóa đi -U và -P 
		Khi đó chỉ còn "sqlcmd -S <Tên server database> -i <Đường dẫn copy bước trước>\data.sql"
	+ Bước 3: Chạy file CreateDatabase.bat bằng quyền Administrator

- Cách 2: Sử dụng trực tiếp file Data.sql để tạo Database bằng cách mở DBMS  Execute file Data.sql 

- Cách 3: Sử dụng file LANCHAT.mdf và LANCHAT_log.ldf bằng cách mở DBMS vào mục Database  chọn attach.. chọn add và mở file .mdf

-----------------
Chỉnh file Config: 
Mở file Server.exe.config bằng notepad hoặc ứng dụng edit khác và chỉnh lại IP server

<add key ="Data Source" value=" Data Source= "Tên server";Initial Catalog=LANCHAT;Integrated Security=True; User Id = "Tài khoản"; Password = "Mật khẩu""/>

*Lưu ý: Nếu không có User id và Password thì khi đó chỉ còn

<add key ="Data Source" value=" Data Source= "Tên server";Initial Catalog=LANCHAT;Integrated Security=True;"/>
