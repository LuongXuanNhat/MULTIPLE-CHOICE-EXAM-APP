# MULTIPLE-CHOICE-EXAM-APP
<br/>
<h2>
Code C# with Entity Framework Code First , MSSQL 
</h2>

<div > Hệ thống thi trắc nghiệm là một phần mềm cung cấp các câu hỏi trắc nghiệm dành cho các cá nhân, tổ chức có nhu cầu sử dụng, và đây cũng là một hình thức thi được ưa chuộng, phù hợp với thời đại công nghệ phát triển. Vượt trội hơn so với các hình thức thi trắc nghiệm truyền thống là bằng giấy, chấm thủ công mất nhiều thời gian và công sức cũng như công việc quản lý tài liệu khó khăn..vv.
Trước khi sử dụng phần mềm người dùng phải đăng nhập vào tài khoản đã được người quản trị cấp, tùy thuộc vào phân quyền của tài khoản mà người dùng có các chức năng và nhiệm vụ thích hợp:
  <p>
Sinh viên: Là đối tượng sử dụng chính của phần mềm để thi cử, kiểm tra. Thông tin sinh viên được lưu trữ vào hệ thống và phân biệt bằng mã số sinh viên, tên sinh viên, lớp, ngày sinh, giới tính, email và số điện thoại liên lạc.
Khi đã đăng nhập vào hệ thống, sinh viên có các lựa chọn: Xem thông tin sinh viên ( có thể chỉnh sửa một số thông tin ), luyện thi, thi ( chức năng này chỉ được kích hoạt khi trong thời gian diễn ra kỳ thi ), ngoài ra sinh viên còn có thể xem bảng điểm của bản thân. Để thi sinh viên cần chọn môn thi và yêu cầu nhập đúng mật khẩu của mã đề thi mà người giám thị cung cấp. Trong quá trình thi, sinh viên có thể nhấn chức năng lưu tạm để phòng tránh việc mất dữ liệu bài thi khi xảy ra sai xót. Sau khi thi, sinh viên sẽ được xem điểm thi, biết số câu đúng, sai trong bài làm. Và ký tên xác nhận điểm. </p>
<p>Giảng viên: Là đối tượng có quyền lập câu hỏi, cũng như chỉnh sửa câu hỏi, ra đề thi. Thông tin giảng viên được lưu trữ vào hệ thống và phân biệt bằng: Mã số giảng viên, họ và tên, chức vụ, khoa/ viện, số điện thoại, email.
Giảng viên dễ dàng quản lý các câu hỏi, đề thi thông qua hệ thống. Và việc tạo câu hỏi, đề thi sẽ được thực hiện gián tiếp qua Excel.</p>
<p>Admin: Là người quản trị hệ thống. Có quyền cao nhất, có thể tạo tài khoản khác cũng như việc phân quyền tài khoản cho người dùng.
Người quản trị (Admin) sẽ có chức năng: quản lý người dùng (Sửa thông tin người dùng, thêm người dùng (phân quyền tài khoản: Giảng viên/sinh viên). Chức năng quản lý hệ thống: Quản lý dữ liệu ( sao lưu, phục hồi dữ liệu ..). Admin có thể tạo kỳ thi và các chức năng quản lý đề thi (thêm, xóa, sửa).</p>
</div>

<h3> Use Case Diagram </h3>
<img src="https://github.com/LuongXuanNhat/MULTIPLE-CHOICE-EXAM-APP/assets/96036623/985fe26e-243b-4431-9cdd-6546b9f6a674" />

<h3> ERD Diagram </h3>
<img src="https://github.com/LuongXuanNhat/MULTIPLE-CHOICE-EXAM-APP/assets/96036623/5824f977-f4fd-498f-8935-55556d563c78" />

<h3> Database Diagram </h3>
<img src="https://github.com/LuongXuanNhat/MULTIPLE-CHOICE-EXAM-APP/assets/96036623/e6df153c-dec0-4020-91c4-f2cebe2653e4" />

<h3> Data files : Code first</h3>
<br>
-------------------------------------
<h3>Started</h3> | run command:
<h2><strong>update-migration</strong></h2>
Done! Goodluck


