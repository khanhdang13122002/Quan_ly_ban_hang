using QuanLyBanHang.Models.EF;
using System;
using System.Linq;

namespace QuanLyBanHang.Models.DAO
{
    public class AuthDAO : BaseDao
    {
        public Users getUserById(string id)
        {
            return db_.Users.Where(us => us.userId == int.Parse(id)).FirstOrDefault();
        }

        public bool login(string username, string password)
        {
            try
            {
                Auth user_ = db_.Auth.Where(au => au.username.Contains(username) && au.password_.Contains(password)).FirstOrDefault();

                if (user_ != null)
                {
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
        public int getMaxUserId()
        {
            var user_ = db_.Users.OrderByDescending(us => us.userId).FirstOrDefault();
            int id = (int)user_.userId;
            return id;
        }
        public int getMaxAuthId()
        {
            var authMax = db_.Auth.OrderByDescending(au => au.authId).FirstOrDefault();
            int id = authMax.authId;
            return id;
        }
        public bool resigter(string user, string pass)
        {
            try
            {
                int maxAuthId = getMaxAuthId();
                int maxUserId = getMaxUserId();
                Auth user_ = db_.Auth.Where(au => au.username.Contains(user)).FirstOrDefault();
                
                if (user_ == null)
                {
                    Auth account = new Auth
                    {
                        authId = maxAuthId + 1,
                        userId = maxUserId + 1,
                        password_ = pass,
                        username = user
                    };
                    Users us = new Users
                    {
                        userId = maxUserId + 1,
                        UserName=user,
                        Email=null,
                        Address_=null,
                        Sdt=null,
                        Avatar=null,
                        Desc_=null
                    };
                   
                       
                        db_.Users.Add(us);
                        db_.Auth.Add(account);
                        db_.SaveChanges();
                        return true;
                    
                        
                }
                else
                {
                    return false;
                }

            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}