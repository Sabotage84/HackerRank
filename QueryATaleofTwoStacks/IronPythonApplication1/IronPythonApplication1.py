class MyQueue(object):
    def __init__(self):
        self.items = []
    
    def peek(self):
        return self.items[0]
        
        
    def pop(self):
        self.items.remove(self.items[0])
        
    def put(self, value):
        self.items.append(value)