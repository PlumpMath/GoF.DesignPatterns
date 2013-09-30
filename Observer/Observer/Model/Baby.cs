namespace Observer.Model
{
    public class Baby : Observable<Baby>
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool isHungry;
        public bool IsHungry
        {
            get { return isHungry; }
            set
            {
                isHungry = value;
                Notify(this);
            }
        }
    }
}
