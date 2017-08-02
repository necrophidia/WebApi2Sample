using SampleWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebAPI.Controllers
{
    public class PostController : ApiController
    {
        Post[] posts = new Post[]
        {
            new Post {
                Id = 1,
                Name = "Post 1",
                Category = "Category 1",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis lacus ligula, vulputate quis pretium quis, auctor et enim. Nulla vulputate non quam eu vulputate."
            },
            new Post {
                Id = 2,
                Name = "Post 2",
                Category = "Category 2",
                Content = "Maecenas in odio est. Sed dapibus, lacus a varius convallis, diam est pulvinar nisi, sit amet malesuada felis libero et turpis."
            },
            new Post {
                Id = 3,
                Name = "Post 3",
                Category = "Category 1",
                Content = "Nam interdum blandit ipsum, quis laoreet lacus volutpat non. Etiam gravida ligula et leo varius malesuada."
            }
        };

        [HttpGet]
        [Route("api/posts")]
        public IEnumerable<Post> GetPosts()
        {
            return posts;
        }

        [HttpGet]
        [Route("api/post/{id}")]
        public IHttpActionResult GetPost(int id)
        {
            var post = posts.FirstOrDefault((p) => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }
    }
}
