/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		
		
		function listBooks() {
			var checkForFilter = arguments[0];
			if (checkForFilter) {
				books = books.filter(function filtering(bookInCollection) {
				return bookInCollection.author === checkForFilter.author || bookInCollection.category === checkForFilter.category ;
				});
			}
			
			books.sort(function booksSortById(a,b) {
				return a.ID - b.ID;
			});
			
			
			return books;	
		}
		function addBook(book) {
			
			if (book.title.length <2 || book.title.length > 100 ) {
				throw new Error('BEgai be!')
			}
			var bookTitleExists = books.some(function (bookInCollection) {
				return bookInCollection.title === book.title;
			});
			
			if (bookTitleExists) {
				throw new Error('Imame veche takava kniga!')
			}
			
			if (book.author === '') {
				throw new Error('Deka si chuvAl za kniga bez avtor!')
			}
			var bookISBNExists = books.some(function (bookInCollection) {
				return bookInCollection.isbn === book.isbn;
			});
			
			if (bookISBNExists ) {
				throw new Error('Greshka')
			}
			if (book.isbn.length !== 10 && book.isbn.length !== 13) {
				throw new Error('Greshka!')
			}
			if (!book.category) {
				book.category = "Default category!"
			}
			
			var bookCategoryExists = categories.some(function (categInCollection) {
				return categInCollection.name === book.category;
			});
			
			if (!bookCategoryExists) {
				
				var newCategory = {
				name : book.category,
				ID : categories.length + 1 
			}
			
			categories.push(newCategory);
			}
			
			book.ID = books.length + 1;
			books.push(book);
			return book;
		}

		function listCategories() {
			categories.sort(function categSortById(a,b) {
				return a.ID - b.ID;
			});
			categories = categories.map(function names(category) {
				return category.name;
			})
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;