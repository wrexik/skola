import tkinter as tk

root = tk.Tk()
canvas = tk.Canvas(root, width=400, height=400)
canvas.pack()

x = 200
y = 200

# all next to each other
canvas.create_text(x-10, y-50, text='Google', font=('Arial', 20))
canvas.create_oval(x-10, y-10, x+10, y+10, fill='#4285F4')
canvas.create_oval(x+10, y-10, x+30, y+10, fill='#EA4335')
canvas.create_oval(x-30, y-10, x-10, y+10, fill='#FBBC04')
canvas.create_oval(x-50, y-10, x-30, y+10, fill='#34A853')

root.mainloop()
