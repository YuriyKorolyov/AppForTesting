// test.js
import { fireEvent, render } from '@testing-library/react';
import App from './App'; 

test('проверка отображения текста при вводе', () => {
    const { getByPlaceholderText, getByText } = render(<App />);
    
    const inputField = getByPlaceholderText('Введите что-то...');
    const button = getByText('Показать текст');

    fireEvent.change(inputField, { target: { value: 'Привет, мир!' } });
    fireEvent.click(button);

    expect(getByText('Привет, мир!')).toBeInTheDocument();
});
