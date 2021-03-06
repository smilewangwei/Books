﻿namespace BookList.BooklistManagement.Books.Dtos
{
    public class BookEditDto
    {
        public long? Id { get; set; }

        /// <summary>
        /// 书名
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Intro { get; set; }

        /// <summary>
        /// 价格链接
        /// </summary>
        public string PriceUrl { get; set; }

        /// <summary>
        /// 封面图片连接
        /// </summary>
        public string ImgUrl { get; set; }
    }
}