function operatorFactory(operator: (result: number) => number) {
    return (
        target: Object,
        propertyName: string,
        propertyDescriptor: PropertyDescriptor,
    ) => {
        const method = propertyDescriptor.value;

        propertyDescriptor.value = function (...args: any[]) {

            const result = method.apply(this, args); 

            return operator(result); 
        }

        return propertyDescriptor;
    }
}

function subtract(value: number = 1) {
    return operatorFactory((num: number) => {
        return num - value;
    });
};



function multiply(value: number = 1) {
    return operatorFactory((num: number) => {
        return num * value;
    });
};

export { multiply, subtract };
