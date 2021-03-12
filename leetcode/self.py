class Restaurant():
    hasInvestors = False
    open247 = False
    drivethru = False
    
    def open_branch(self):
        if not self.hasInvestors:
            print("Location can not be opened")
        elif self.hasInvestors:
            print("Open for business")
            
            
    def order_late(self):
        if not self.hasInvestors or not self.open247 and not self.drivethru:
            print("Order can not be made")
        else:
            print("Order please?")
    


wendys = Restaurant()
wendys.hasInvestors = True
wendys.open247 = True
wendys.drivethru = True
wendys.open_branch()
wendys.order_late()

chipotle = Restaurant()
chipotle.open247 = True
chipotle.drivethru = True
chipotle.open_branch()
chipotle.order_late()
