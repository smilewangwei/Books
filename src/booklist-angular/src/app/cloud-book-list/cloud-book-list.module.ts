import { TitleService } from '@yoyo/theme';
import { AbpModule, LocalizationService } from '@yoyo/abp';
import { SharedModule } from '@shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CloudBookListRoutingModule } from './cloud-book-list-routing.module';
import { BookListsComponent } from './book-lists/book-lists.component';
import { BooksComponent } from './books/books.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { CreateOrEditBookComponent } from './create-or-edit-book/create-or-edit-book.component';

@NgModule({
  imports: [
    CommonModule,
    CloudBookListRoutingModule,
    HttpClientModule,
    SharedModule,
    AbpModule,
  ],
  declarations: [BookListsComponent, BooksComponent, CreateOrEditBookComponent],
  // 使用的组件
  entryComponents: [
    BookListsComponent,
    BooksComponent,
    CreateOrEditBookComponent,
  ],

  providers: [LocalizationService, TitleService],
})
export class CloudBookListModule {}
