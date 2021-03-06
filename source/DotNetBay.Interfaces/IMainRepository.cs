﻿using System;
using System.Linq;

using DotNetBay.Model;

namespace DotNetBay.Interfaces
{
    public interface IMainRepository
    {
        IQueryable<Auction> GetAuctions();

        IQueryable<Member> GetMembers();

        Auction Add(Auction auction);

        Auction Update(Auction auction);

        Bid Add(Bid bid);

        Bid GetBidByTransactionId(Guid transactionId);

        Member Add(Member member);

        void SaveChanges();
    }
}