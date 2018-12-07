import { CreateOrEditBookComponent } from './../create-or-edit-book/create-or-edit-book.component';
import { finalize } from 'rxjs/operators';
import {
  BookDto,
  BookServiceProxy,
} from './../../../shared/service-proxies/service-proxies';
import {
  PagedListingComponentBase,
  PagedRequestDto,
} from '@shared/component-base/paged-listing-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { Component, OnInit, Injector } from '@angular/core';
// import _ = require('lodash');
import * as _ from 'lodash';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styles: ['/books.component.less'],

  // 引入加载动画
  animations: [appModuleAnimation()],
})
export class BooksComponent extends PagedListingComponentBase<BookDto>
  implements OnInit {
  /**
   *默认获取后端分页数据列表信息
   * @param request 请求数据的Dto，比如分页
   * @param pageNumber 当前的页码
   * @param finishedCallback 完成请求后的回调信息
   */
  protected fetchDataList(
    request: PagedRequestDto,
    pageNumber: number,
    finishedCallback: Function,
  ): void {
    this._bookservice
      .getPagedBook(
        this.filterText,
        request.sorting,
        request.skipCount,
        request.maxResultCount,
      )
      .pipe(
        finalize(() => {
          finishedCallback();
        }),
      )
      .subscribe(rseult => {
        this.dataList = rseult.items;
        this.showPaging(rseult);
      });
  }
  /**
   *删除
   * @param entity
   */
  delete(entity: BookDto): void {
    this._bookservice.deleteBook(entity.id).subscribe(() => {
      // 刷新表格数据并跳转到第一页
      this.refreshGoFirstPage();

      this.notify.success('信息删除成功！');
    });
  }
  /**
   *批量删除
   */
  batchDelete(): void {
    const selectIdCount = this.selectedDataItems.length;

    if (selectIdCount <= 0) {
      abp.message.warn('请选择您要删除的信息');
      return;
    }
    abp.message.confirm('是否确认删除选中信息', res => {
      if (res) {
        const ids = _.map(this.selectedDataItems, 'id');
        this._bookservice.batchDeleteBook(ids).subscribe(() => {
          this.refreshGoFirstPage();
          abp.notify.success('信息删除成功');
        });
      }
    });
  }

  /**
   * 添加修改页面
   * @param id
   */
  createOrEdit(id?: number): void {
    this.modalHelper
      .static(CreateOrEditBookComponent, { id: id })
      .subscribe(resule => {
        if (resule) {
          this.refresh();
        }
      });
  }
  constructor(injector: Injector, private _bookservice: BookServiceProxy) {
    super(injector);
  }

  // ngOnInit() {}
}
