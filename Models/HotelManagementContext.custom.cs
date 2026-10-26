using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.Models
{
    // File riêng (partial) để bổ sung cấu hình / phương thức tùy chỉnh cho HotelManagementContext
    public partial class HotelManagementContext : DbContext
    {
        // Ghi chú: Constructor rỗng và OnConfiguring đã được định nghĩa trong HotelManagementContext.cs
        // Khi cần chỉnh sửa chuỗi kết nối, hãy cập nhật tại OnConfiguring trong HotelManagementContext.cs
    }
}
