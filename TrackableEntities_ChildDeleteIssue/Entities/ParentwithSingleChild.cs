using TrackableEntities.Client;

namespace TrackableEntities_ChildDeleteIssue.Entities
{
    public class ParentwithSingleChild :EntityBase
    {
        private int _parentId;
        private string _parentName;
        private Child _child;

        public int ParentId
        {
            get => _parentId;
            set
            {
                if (Equals(value, _parentId)) return;
                _parentId = value;
                NotifyPropertyChanged();
            }
        }


        public string ParentName
        {
            get => _parentName;
            set
            {
                if (Equals(value, _parentName)) return;
                _parentName = value;
                NotifyPropertyChanged();
            }
        }

        public Child Child
        {
            get => _child;
            set
            {
                if (Equals(value, _child)) return;
                _child = value;
            }
        }
    }
}