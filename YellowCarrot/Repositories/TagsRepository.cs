using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using YellowCarrot.Data;
using YellowCarrot.Models;

namespace YellowCarrot.Repositories
{
    internal class TagsRepository
    {
        private readonly AppDbContext _context;

        public TagsRepository (AppDbContext context)
        {
            _context = context;
        }

        public void CeateTags(Tags newTags)
        {
            _context.Tags.Add(newTags);
        }

        public Tags? GetTag(string name)
        {
            return _context.Tags.FirstOrDefault(t => t.Name == name);
        }

        public List<Tags>? GetTags()
        {
            return _context.Tags.ToList();
        }
    }
}
