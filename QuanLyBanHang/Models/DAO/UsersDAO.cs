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
        public List<User> GetAll(string key)
        {
            if (key != null)
            {
                return getUsersByKey(key);
            }
            return db_.Users.ToList();
        }
        public List<User>getUsersByKey(string key)
        {
            return db_.Users.Where(us => us.UserName.Contains(key) || us.Email.Contains(key) || us.Address_.Contains(key)).ToList();
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
        public bool InsertNewUser(User info,int id)
        {
            try
            {
                db_.Users.Add(info);
                addHis(id, "Them Nguoi Dung", true);
                db_.SaveChanges();
            } catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        // Update thông tin user
        public bool Update(User info,int id)
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
                    addHis(id, "Sua Nguoi Dung", true);

                    db_.SaveChanges();
                }
            } catch(Exception ex)
            {
                return false;
            }
            return true;
        }
        public Auth getAuthById(int userId)
        {
            return db_.Auths.Where(au => au.userId == userId).FirstOrDefault();
        }
        // Xóa user theo id
        public bool Delete(int userID,int id)
        {
            try
            {
                Auth auth = getAuthById(userID);
                var getUserID = GetSingleByID(userID);
                if (getUserID != null)
                {
                    db_.Users.Remove(getUserID);
                    db_.Auths.Remove(auth);
                    addHis(id, "Xoa Nguoi Dung", true);
                    db_.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            } catch(Exception ex)
            {
                return false;
            }
        }

        public bool addHis(int user_id, string action_, bool isUsers_)
        {
            try
            {
                hisDao hisDao_ = new hisDao();
                DateTime time_ = DateTime.Now;
                int hisId = hisDao_.getMaxId();
                history newHis = new history
                {
                    historyId = hisId + 1,
                    time = time_,
                    userId = user_id,
                    action = action_,
                    isUser = isUsers_
                };
                bool result = hisDao_.addHis(newHis);
                if (result)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
