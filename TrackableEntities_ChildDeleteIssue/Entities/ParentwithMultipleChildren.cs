using TrackableEntities.Client;

namespace TrackableEntities_ChildDeleteIssue.Entities
{
    public class ParentwithMultipleChildren :EntityBase
    {
        private int _parentId;
        private string _parentName;
        private ChangeTrackingCollection<Child> _children;

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

        public ChangeTrackingCollection<Child> Children
        {
            get => _children;
            set
            {
                if (Equals(value, _children)) return;
                _children = value;
            }
        }
    }
}