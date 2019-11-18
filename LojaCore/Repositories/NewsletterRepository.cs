using LojaCore.Database;
using LojaCore.Models;
using LojaCore.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCore.Repositories
{
    public class NewsletterRepository : INewsletterRepository
    {
        private LojaCoreContext _banco;
        public NewsletterRepository(LojaCoreContext banco)
        {
            _banco = banco;
        }

        public void Cadastrar(NewsletterEmail newsletter)
        {
            _banco.NewsletterEmails.Add(newsletter);
            _banco.SaveChanges();
        }

        public IEnumerable<NewsletterEmail> ObterTodasNewsletter()
        {
            return _banco.NewsletterEmails.ToList();
        }
    }
}
