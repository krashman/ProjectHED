﻿using System;

namespace ProjectHEDio
{
    public class ScrapedFile
    {
        private string Link;
        private int Retries = 0;
        private int Width = -1;
        private int Height = -1;

        public ScrapedFile()
        {
            throw new NotSupportedException();
        }

        public ScrapedFile(string link)
        {
            this.Link = link;
        }

        public ScrapedFile(string link, int retries)
        {
            this.Link = link;
            this.Retries = retries;
        }

        public ScrapedFile(string link, int width, int height)
        {
            this.Link = link;
            this.Width = width;
            this.Height = height;
        }
    }
}
