using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Ivony.Fluent;

namespace Ivony.Html
{

  /// <summary>
  /// 实现一个线程安全的容器
  /// </summary>
  /// <typeparam name="T">元素类型</typeparam>
  public sealed class SynchronizedList<T> : Collection<T>, ICollection
  {

    /// <summary>
    /// 创建 SynchronizedList 对象
    /// </summary>
    public SynchronizedList() : this( new object() ) { }


    /// <summary>
    /// 创建 SynchronizedList 对象
    /// </summary>
    /// <param name="sync">用于同步的对象</param>
    public SynchronizedList( object sync )
    {
      _sync = sync;
    }

    protected override void InsertItem( int index, T item )
    {
      lock ( SyncRoot )
      {
        base.InsertItem( index, item );
      }
    }

    protected override void ClearItems()
    {
      lock ( SyncRoot )
      {
        base.ClearItems();
      }
    }

    protected override void RemoveItem( int index )
    {
      lock ( SyncRoot )
      {
        base.RemoveItem( index );
      }
    }

    protected override void SetItem( int index, T item )
    {
      lock ( SyncRoot )
      {
        base.SetItem( index, item );
      }
    }

    private object _sync;

    public object SyncRoot
    {
      get
      {
        return _sync;
      }
    }


    object ICollection.SyncRoot
    {
      get { return _sync; }
    }


  }
}
