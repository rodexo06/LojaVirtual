using LojaCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCore.Repositories.Contracts
{
    public interface INewsletterRepository
    {
        void Cadastrar(NewsletterEmail newsletter);

        IEnumerable<NewsletterEmail> ObterTodasNewsletter();
    }
}
