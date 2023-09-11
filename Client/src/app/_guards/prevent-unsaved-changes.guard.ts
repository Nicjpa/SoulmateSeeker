import { CanDeactivateFn } from '@angular/router';
import { MemberEditComponent } from '../members/member-edit/member-edit.component';

export const preventUnsavedChangesGuard: CanDeactivateFn<unknown> = (component: MemberEditComponent) : boolean => {
  if(component.editForm.dirty) {
    return confirm("Are you sure you want to continue? Any unsaved changes will be lost");
  }
  return true;
};
