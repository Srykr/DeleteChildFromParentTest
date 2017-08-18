using TrackableEntities.Client;

namespace TrackableEntities_ChildDeleteIssue.Entities
{
    public class Child :EntityBase
    {
        private int _childId;
        private string _childName;
        private int _parentId;

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
        public int ChildId
        {
            get => _childId;
            set
            {
                if (Equals(value, _childId)) return;
                _childId = value;
                NotifyPropertyChanged();
            }
        }

        public string ChildName
        {
            get => _childName;
            set
            {
                if (Equals(value, _childName)) return;
                _childName = value;
                NotifyPropertyChanged();
            }
        }
    }
}