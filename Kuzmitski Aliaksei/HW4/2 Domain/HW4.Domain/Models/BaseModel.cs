﻿namespace HW4.Domain.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        public BaseModel(int id)
        {
            Id = id;
        }
    }
}
