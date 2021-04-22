import { FormattedMessagePlaceholderValues } from "./FormattedMessagePlaceholderValues";


export interface Error {
    propertyName: string;
    errorMessage: string;
    attemptedValue: Date;
    customState?: any;
    severity: number;
    errorCode: string;
    formattedMessagePlaceholderValues: FormattedMessagePlaceholderValues;
  }

