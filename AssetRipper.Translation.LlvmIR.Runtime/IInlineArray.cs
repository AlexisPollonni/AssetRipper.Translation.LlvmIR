namespace AssetRipper.Translation.LlvmIR.Runtime;

public interface IInlineArray<out T>
{
	static abstract int Length { get; }
}

public interface IInlineArray<TSelf, out TElement> : IInlineArray<TElement>, IReadOnlyList<TElement>
	where TSelf : struct, IInlineArray<TElement>
{
	TElement IReadOnlyList<TElement>.this[int index]
	{
		get
		{
			TSelf temp = (TSelf)this;
			return InlineArrayHelper.GetElement<TSelf, TElement>(ref temp, index);
		}
	}
	int IReadOnlyCollection<TElement>.Count => TSelf.Length;
	IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator()
	{
		for (int i = 0; i < TSelf.Length; i++)
		{
			yield return ((IReadOnlyList<TElement>)this)[i];
		}
	}
}
