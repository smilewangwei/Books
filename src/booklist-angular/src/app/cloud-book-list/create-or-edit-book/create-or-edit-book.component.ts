import { ModalComponentBase } from '@shared/component-base';
import {
  BookEditDto,
  BookServiceProxy,
  CreateOrUpdateBookInput,
} from './../../../shared/service-proxies/service-proxies';
import { Component, OnInit, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-create-or-edit-book',
  templateUrl: './create-or-edit-book.component.html',
  styles: [],
})
export class CreateOrEditBookComponent extends ModalComponentBase
  implements OnInit {
  constructor(injector: Injector, private _bookService: BookServiceProxy) {
    super(injector);
  }
  id: any;
  entity: BookEditDto = new BookEditDto();

  /**
   *编辑
   */
  init(): void {
    this._bookService.getForEditBook(this.id).subscribe(res => {
      this.entity = res.book;
    });
  }

  /**
   * 保存信息
   */
  submitForm(): void {
    const input = new CreateOrUpdateBookInput();
    input.book = this.entity;
    this.saving = true;
    this._bookService
      .createOrUpdateBook(input)
      .pipe(
        finalize(() => {
          this.saving = false;
        }),
      )
      .subscribe(() => {
        abp.notify.success('信息保存成功');
      });
  }

  ngOnInit() {
    this.init();
  }
}
