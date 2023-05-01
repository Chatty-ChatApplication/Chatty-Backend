﻿using Domain.ValueObjects.Commons;

namespace Domain.Entities;

public class UserAccount : EntityBase
{
   public AuthProviderId AuthProviderId { get; set; }

   public UserAccount(Guid id, AuthProviderId authProviderId) : base(id)
   {
      AuthProviderId = authProviderId;
   }
}