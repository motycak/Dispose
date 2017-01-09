namespace ConsoleApplication1
{
    class B : A
    {
        private bool disposed = false;



        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    var a = 2;
                }

                // new shared cleanup logic
                disposed = true;
            }

            base.Dispose(disposing);
        }

    }
}
