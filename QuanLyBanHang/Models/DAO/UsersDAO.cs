using QuanLyBanHang.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models.DAO
{
    public class UsersDAO : BaseDao
    {
        // Lấy tất cả user
        public List<User> GetAll()
        {
            return db_.Users.ToList();
        }

        // Lấy danh sách user phù hợp với keyword
        public List<User> GetByKeyword(string keyword)
        {
            return db_.Users.Where(t => t.UserName.Contains(keyword)).ToList();
        }

        // Lấy theo id
        public User GetSingleByID(int userID)
        {
            return db_.Users.Where(t => t.userId == userID).FirstOrDefault();
        }

        // Lấy email để kiểm tra khi thêm hoặc sửa
        public User GetEmail(string email)
        {
            return db_.Users.Where(t => t.Email == email).FirstOrDefault();
        }

        // Lấy id lớn nhất trong danh sách
        public int getMaxId()
        {
            var reslut = db_.Users.OrderByDescending(t => t.userId).FirstOrDefault();
            return reslut.userId;
        }

        // Thêm user mới vào db
        public bool InsertNewUser(User info)
        {
            try
            {
                db_.Users.Add(info);
                db_.SaveChanges();
            } catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        // Update thông tin user
        public bool Update(User info)
        {
            try
            {
                var getUser = GetSingleByID(info.userId);
                if (getUser != null)
                {
                    getUser.UserName = info.UserName;
                    getUser.Email = info.Email;
                    getUser.Address_ = info.Address_;
                    getUser.Sdt = info.Sdt;
                    getUser.Desc_ = info.Desc_;
                    if (getUser.Avatar != info.Avatar) getUser.Avatar = info.Avatar;

                    db_.SaveChanges();
                }
            } catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        // Xóa user theo id
        public bool Delete(int userID)
        {
            try
            {
                var getUserID = GetSingleByID(userID);
                if (getUserID != null)
                {
                    db_.Users.Remove(getUserID);
                    db_.SaveChanges();
                }
            } catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
