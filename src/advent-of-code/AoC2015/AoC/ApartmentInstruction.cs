namespace AoC
{
    public class ApartmentInstruction
    {
        private string _construction;

        public ApartmentInstruction(string construction)
        {
            SetConstruction(construction);
        }

        public string Construction
        {
            get { return _construction; }
        }

        public int Floor { get; set; }

        public void SetConstruction(string construction)
        {
            _construction = construction;
        }

        public int CulculateFloor()
        {
            foreach (var instruction in Construction)
            {
                switch (instruction)
                {
                    case '(':
                        GoUpFloor();
                        break;

                    case ')':
                        GoDownFloor();
                        break;
                }
            }

            return Floor;
        }

        private void GoUpFloor()
        {
            Floor++;
        }

        private void GoDownFloor()
        {
            Floor--;
        }
    }
}
