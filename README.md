# LearnTestXUnit

## 🎯 Học Test xUnit cấp tốc trong 2 giờ

---

## 🧱 Domain

- **User**: Entity gồm các thuộc tính `Id`, `Name`, `Email`.
- **IUserRepository**: Interface định nghĩa các phương thức CRUD cho entity `User`.

---

## 🏗️ Infrastructure

- Sử dụng **In-Memory** để lưu trữ dữ liệu tạm thời (giả lập database).

---

## 🧠 Services

- Chứa logic xử lý CRUD cho entity `User`, gọi qua `UserService`.

---

## 🧪 LearnTestX (Testing Layer)

### ✅ TestDemo

Giúp nắm rõ cấu trúc của một phương thức test với 3 phần chính:

1. **Arrange**: Chuẩn bị tài nguyên phục vụ test (mock, data...).
2. **Act**: Thực thi hành vi cần kiểm thử.
3. **Assert**: So sánh kết quả mong đợi với kết quả thực tế.

**Ghi chú:**
- `[Fact]`: Dùng cho test **độc lập**, không nhận tham số.
- `[Theory]`: Dùng cho test **có tham số**, có thể kết hợp với:
  - `[InlineData]`: Truyền trực tiếp giá trị.
  - `[MemberData]`, `[ClassData]`: Truyền từ nguồn bên ngoài.

---

### ✅ UserServiceTest

Thực hành test với `UserService`.

- **Arrange**: Tạo một `mockRepository` — mô phỏng `IUserRepository` bằng thư viện Moq.
- **Act**: Thực thi một phương thức trong `UserService` (ví dụ: `RegisterUserAsync`).
- **Assert**: Kiểm tra kết quả trả về có đúng như kỳ vọng không.

---

## 💡 Mục tiêu

Hiểu và thực hành được:
- Cấu trúc cơ bản của unit test trong xUnit.
- Cách sử dụng Moq để mock repository.
- Phân biệt `[Fact]` và `[Theory]`, áp dụng phù hợp.