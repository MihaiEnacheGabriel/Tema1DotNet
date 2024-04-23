using LabProject.Database.Dtos.Request;
using LabProject.Database.Entities;
using LabProject.Database.Enums;
using System.Linq;

namespace LabProject.Database.QueryExtensions
{
    public static class AuthorQueryExtensions
    {
        public static IQueryable<Author> WhereName(this IQueryable<Author> query, GetAuthorsRequest payload)
        {
            if (string.IsNullOrEmpty(payload.Name))
                return query;

            query = query.Where(e => e.Name.Contains(payload.Name));

            return query;
        }

        public static IQueryable<Author> Sort(this IQueryable<Author> query, SortingCriterionDto sortingCriterion)
        {
            if (sortingCriterion == null)
                return query.OrderBy(e => e.Name);

            switch (sortingCriterion.Criterion)
            {
                case SortingCriterion.ByName:
                    {
                        if (sortingCriterion.Order == SortingOrder.Ascending)
                            return query.OrderBy(e => e.Name);
                        else
                            return query.OrderByDescending(e => e.Name);
                    }

                default: return query;
            }
        }
    }

    public static class SongQueryExtensions
    {
        public static IQueryable<Song> WhereTitle(this IQueryable<Song> query, GetSongsRequest payload)
        {
            if (string.IsNullOrEmpty(payload.Title))
                return query;

            query = query.Where(e => e.Title.Contains(payload.Title));

            return query;
        }

        public static IQueryable<Song> WhereAuthorId(this IQueryable<Song> query, GetSongsRequest payload)
        {
            if (payload.AuthorId == null)
                return query;

            query = query.Where(e => e.AuthorId == payload.AuthorId);

            return query;
        }

        public static IQueryable<Song> Sort(this IQueryable<Song> query, SortingCriterionDto sortingCriterion)
        {
            if (sortingCriterion == null)
                return query.OrderBy(e => e.Title);

            switch (sortingCriterion.Criterion)
            {
                case SortingCriterion.ByTitle:
                    {
                        if (sortingCriterion.Order == SortingOrder.Ascending)
                            return query.OrderBy(e => e.Title);
                        else
                            return query.OrderByDescending(e => e.Title);
                    }

                default: return query;
            }
        }
    }
}
