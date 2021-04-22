import { Error } from "./Error";


    export interface ValidationResult {
        isValid: boolean;
        errors: Error[];
        ruleSetsExecuted: string[];
    }

