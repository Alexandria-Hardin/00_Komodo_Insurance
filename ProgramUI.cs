using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Komodo_Insurance
{
    class ProgramUI
    {
        protected readonly DeveloperRepo _streamingRepo//fix this name = new DeveloperRepos();

        //This is the method that runs our User Interface
        public void Run()
        {
            //Putting in seed data to have some starting data
            SeedContentList();

            DisplayMenu();
    }
}
