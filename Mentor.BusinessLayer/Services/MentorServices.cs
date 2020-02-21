using Mentor.Entities;
using MentorOnDemand.BuisnessLayer.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.BuisnessLayer.Services
{
    public class MentorServices : IMentorServices
    {
        public bool AcceptProposal(int UserId)
        {
            return true;
        }

        public MentorDtl AddProfile(long MentorId)
        {
            MentorDtl mentor = new MentorDtl();
            return mentor;

        }

        public MentorDtl EditProfile(long MentorId)
        {
            MentorDtl mentor = new MentorDtl();
            return mentor;

        }


        public MentorDtl ViewMentor(long Id)
        {
            MentorDtl mentordetails = new MentorDtl();
            return mentordetails;
        }

        public MentorDtl ViewProfile(long MentorId)
        {
            MentorDtl mentor = new MentorDtl();
            return mentor;

        }

        public User ViewProposal(long UserId)
        {
            User user = new User();
            return user;

        }

        MentorDtl IMentorServices.AddProfile(long MentorId)
        {
            throw new NotImplementedException();
        }

        MentorDtl IMentorServices.EditProfile(long MentorId)
        {
            throw new NotImplementedException();
        }

        MentorDtl IMentorServices.ViewMentor(long MentorId)
        {
            throw new NotImplementedException();
        }

        MentorDtl IMentorServices.ViewProfile(long MentorId)
        {
            throw new NotImplementedException();
        }

        User IMentorServices.ViewProposal(long UserId)
        {
            throw new NotImplementedException();
        }
    }
}
