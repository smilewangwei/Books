import { BooksComponent } from './books/books.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookListsComponent } from './book-lists/book-lists.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'books',
        component: BooksComponent,
        data: { permission: 'Pages.BookManager' }, // 解决地址栏直接路由到页面，页面显示异常
      },
      {
        path: 'book-lists',
        component: BookListsComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CloudBookListRoutingModule {}
