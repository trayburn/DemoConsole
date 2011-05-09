using System;
using System.Collections.Generic;

namespace DemoConsole
{
    public class CatalogContext
    {
        public IEnumerable<Category> GetData()
        {
            return new[] { 
		        new Category 
		        { 
		            Description = "A selection of technology titles", 
		            Name = "Technology", 
		            Products = new List<Product>() 
		            { 
		                new Product 
		                { 
		                    Id = 1, 
		                    Description = @"Mixing provocative insights and cliched criticisms, Postman defines the U.S. as a society in which technology is deified to a near-totalitarian degree.", 
		                    Name = " Technopoly: The Surrender of Culture to Technology", 
		                    Price = 12.99 
		                }, 
		                new Product 
		                { 
		                    Id = 2, 
		                    Description = @"Applying the lessons of history to modern-day dilemmas, Nye defies much common wisdom about the power of technology in society. With irony and wit, he exhorts us not to succumb to defeatist notions of technological determinism but to take charge of our own human destinies", 
		                    Name = "Technology Matters: Questions to Live With ", 
		                    Price = 10.76 
		                }, 
		                new Product 
		                { 
		                    Id = 3, 
		                    Description = @"This historical account achieves its basic aim of demonstrating that, with the exception of quite recent history, technology has always influenced science, not the other way round.", 
		                    Name = "Science and Technology in World History: An Introduction", 
		                    Price = 17.82 
		                } 
		            } 
		        }, 
		        new Category 
		        { 
		            Description = "A selection of titles to read with the light on", 
		            Name = "Horror", 
		            Products = new List<Product>() 
		            { 
		                new Product 
		                { 
		                    Id = 4, 
		                    Description = @"Dracula begins with the journal of Jonathan Harker, a young solicitor on the way to Transylvania to give information to the mysterious Count Dracula about his new estate in London. Dracula takes the young man prisoner, and Jonathan sees many strange and evil things in the castle before escaping and fleeing into the night. He later decides that he must have been mad.", 
		                    Name = "Dracula", 
		                    Price = 15.95 
		                }, 
		                new Product 
		                { 
		                    Id = 5, 
		                    Description = @"The story of Victor Frankenstein's monstrous creation and the havoc it caused has enthralled generations of readers and inspired countless writers of horror and suspense. Includes the author's own 1831 introduction.", 
		                    Name = "Frankenstein", 
		                    Price = 2.99 
		                }, 
		                new Product 
		                { 
		                    Id = 6, 
		                    Description = @"This University of Nebraska Press edition is a small, exquisitely produced paperback. The book design, based on the original first edition of 1886, includes wide margins, decorative capitals on the title page and first page of each chapter, and a clean, readable font that is 19th-century in style. Joyce Carol Oates contributes a foreword in which she calls Dr. Jekyll and Mr. Hyde a mythopoetic figure like Frankenstein, Dracula, and Alice in Wonderland, and compares Stevenson's creation to doubled selves in the works of Plato, Poe, Wilde, and Dickens.", 
		                    Name = "The Strange Case of Dr. Jekyll and Mr. Hyde ", 
		                    Price = 1.59 
		                }
		            }
		        }
		    };
        }
    }
}
