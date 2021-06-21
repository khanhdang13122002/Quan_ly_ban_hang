using System;
using System.Linq;
using QuanLyBanHang.Models.EF;
namespace QuanLyBanHang.Models.DAO
{
    public class AuthDAO : BaseDao
    {
        public User getUserById(string id)
        {
            return db_.Users.Where(us => us.userId == int.Parse(id)).FirstOrDefault();
        }

        public Auth GetAuthByID(int id)
        {
            return db_.Auths.Where(t => t.authId == id).FirstOrDefault();
        }

        public Auth login(string username, string password)
        {
            try
            {
                Auth user_ = db_.Auths.Where(au => au.username.Contains(username) && au.password_.Contains(password)).FirstOrDefault();

                if (user_ != null)
                {
                    return user_;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public int getMaxUserId()
        {
            var user_ = db_.Users.OrderByDescending(us => us.userId).FirstOrDefault();
            int id = (int)user_.userId;
            return id;
        }
        public int getMaxAuthId()
        {
            var authMax = db_.Auths.OrderByDescending(au => au.authId).FirstOrDefault();
            int id = authMax.authId;
            return id;
        }
       
        public bool resigter(string user, string pass)
        {
            try
            {
                int maxAuthId = getMaxAuthId();
                int maxUserId = getMaxUserId();
                Auth user_ = db_.Auths.Where(au => au.username.Contains(user)).FirstOrDefault();

                if (user_ == null)
                {
                    Auth account = new Auth
                    {
                        authId = maxAuthId + 1,
                        userId = maxUserId + 1,
                        password_ = pass,
                        username = user
                    };
                    User us = new User
                    {
                        userId = maxUserId + 1,
                        UserName = user,
                        Email = null,
                        Address_ = null,
                        Sdt = null,
                        Avatar = null,
                        Desc_ = null
                    };


                    db_.Users.Add(us);
                    db_.Auths.Add(account);
                    db_.SaveChanges();
                    return true;


                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Auth info, int id)
        {
            try
            {
                var getAuth = GetAuthByID(id);
                if (getAuth != null)
                {
                    getAuth.username = info.username;
                    getAuth.password_ = info.password_;
                    addHis(id, "Sua Nguoi Dung", true);

                    db_.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
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