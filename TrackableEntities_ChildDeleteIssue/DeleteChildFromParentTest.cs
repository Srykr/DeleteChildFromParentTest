using System.Linq;
using FluentAssertions;
using TrackableEntities;
using TrackableEntities.Client;
using TrackableEntities_ChildDeleteIssue.Entities;
using Xunit;

namespace TrackableEntities_ChildDeleteIssue
{
    public class DeleteChildFromParentTest
    {

        [Fact]
        public void DeleteSingleFromParentOneToOne()
        {
            var parentwithSingleChild = new ChangeTrackingCollection<ParentwithSingleChild>( 
                new ParentwithSingleChild
                {
                    ParentId = 1,
                    ParentName = "ParentName1",
                    Child = new Child
                    {
                        ParentId = 1,
                        ChildId = 1,
                        ChildName = "ChildName2"
                    }
                });

            parentwithSingleChild.First().Child.TrackingState = TrackingState.Deleted;

            var changes = parentwithSingleChild.GetChanges();

            changes.Should().HaveCount(1);

        }

        [Fact]
        public void DeleteChildFromParentOneToMany()
        {
            
            var parentwithMultipleChildren = new ChangeTrackingCollection<ParentwithMultipleChildren>(new ParentwithMultipleChildren
            {
                ParentId = 1,
                ParentName = "ParentName1",
                Children = new ChangeTrackingCollection<Child>
                {
                    new Child
                    {
                        ParentId =1,
                        ChildId = 1,
                        ChildName = "ChildName2"
                    },
                    new Child
                    {
                        ParentId =1,
                        ChildId = 2,
                        ChildName = "ChildName2"
                    }
                }
            });

            parentwithMultipleChildren.First().Children.First().TrackingState = TrackingState.Deleted;

            var changes = parentwithMultipleChildren.GetChanges();

            changes.Should().HaveCount(1);
        }

    }
}