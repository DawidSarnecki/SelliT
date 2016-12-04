using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SelliT.Domain.Abstract;

namespace SelliT.WebUI.Controllers
{
    public class ContractorController : Controller
    {
        private IContractorRepository repository;
        // GET: Contractor

        public ContractorController(IContractorRepository contractorRepository)
        {
            this.repository = contractorRepository;
        }

        public ActionResult List()
        {
            return View(repository.Contractor);
        }
    }
}