Entity ID是唯一标识单个轴网和块的值。您可以通过项目的`EntityId`属性访问它。即使您重新加载您的世界，该值也保证在相关项目的整个生命周期内保持不变

### 何时重新创建实体
这里有一些警告。块是非常清晰的，只要它们存在，它们就会有相同的ID。不过网格有点难处理.

**合并块**是一种非常流行的对接夹具，人们常常没有意识到这并不是这个块真正的设计目的。它最初的目的是将网格永久地合并在一起，因此得名. 
当使用合并块将栅格锁定在一起时，其中一个栅格中的所有块都将移动到另一个栅格，然后第一个栅格将被_destroyed_。当你再次解锁时，游戏会创建一个_new_网格，并将块从合并网格移动到这个新网格。这意味着无论何时使用合并块，可编程块的网格实体ID都会放置在_might change_上。如果您打算使用此值，那么作为脚本编写者，您需要注意这一点.

### 蓝图和复制粘贴
这一点应该很明显。当您从蓝图或创意复制/粘贴中粘贴新网格时，与原始副本或蓝图相比，所有网格和块都将获得新ID。