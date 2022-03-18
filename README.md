# fillr2.0
Programming productivity tool to write repetitive code

## Usage
Say I need to write the following code:
```
MessageBox.Show("This is the first message!");
MessageBox.Show("This is the second message!");
MessageBox.Show("This is the third message!");
```

I can make this a template:
```
MessageBox.Show("This is the <<count>> message!");

```
(Note the newline that is included above.)

Then fillr2.0 will iterate through the template infinitely and prompt you to input ```<<count>>``` each iteration.

## Other
Supports multiple variables, although does not support same variable in multiple places.
Planning to add ability to have auto-incrementing variables so you don't have to type it each iteration.
