﻿using Data.Base;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Data.Model
{
    public class Batch 
    {
        [Key]
        public string Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTimeOffset JoinDate { get; set; }
        public DateTimeOffset FinishDate { get; set; }

        public Batch() { }

        public Batch(BatchVM batchVM)
        {
            this.Id = batchVM.Id;
            this.Name = batchVM.Name;
            this.Type = batchVM.Type;
            this.JoinDate = batchVM.JoinDate;
            this.FinishDate = batchVM.FinishDate;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(BatchVM batchVM)
        {
            this.Name = batchVM.Name;
            this.JoinDate = batchVM.JoinDate;
            this.FinishDate = batchVM.FinishDate;
            this.UpdateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;

        }
    }
}