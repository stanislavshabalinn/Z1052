using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Z1052.Program;

namespace Z1052
{
    internal class Worker1
    {
    }
}
public class Worker1 : IWorker
{

    ILogger logger { get; }
    public Worker1(ILogger logger)
    {
        logger = logger;
    }
    public void Work()
    {
        logger.Event("Worker 1 начал свою работу");
        Thread.Sleep(3000);
        logger.Event("Worker 1 окончил свою работу");
    }


    public internal class Worker2 : IWorker
    {
        
        Logger logger { get; }
        public Worker2(ILogger logger)
        {
            logger = logger;
        }
        public void Work()
        {
            logger.Event("Worker 2 начал свою работу");
            Thread.Sleep(3000);
            logger.Event("Worker 2 окончил свою работу");
        }
    }
    public internal class Worker3 : IWorker
    {

        ILogger logger { get; }
        public Worker3(ILogger logger)
        {
            logger = logger;
        }
        public void Work()
        {
            logger.Event("Worker 3 начал свою работу");
            Thread.Sleep(3000);
            logger.Event("Worker 3 окончил свою работу");
        }
    }
}
}
