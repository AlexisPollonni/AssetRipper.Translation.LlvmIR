using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const.atan2.CONST_ADJ")]
[DemangledName("__const.atan2.CONST_ADJ")]
[CleanName("CONST_ADJ")]
internal static partial class CONST_ADJ_5izt5t
{
	[FixedAddressValueType]
	private static InlineArray2_InlineArray2_InlineArray2_NumberPair __value;

	public unsafe static InlineArray2_InlineArray2_InlineArray2_NumberPair* Pointer => unchecked((InlineArray2_InlineArray2_InlineArray2_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray2_InlineArray2_InlineArray2_NumberPair Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static CONST_ADJ_5izt5t()
	{
		Value = new InlineArrayBuilder<InlineArray2_InlineArray2_InlineArray2_NumberPair, InlineArray2_InlineArray2_NumberPair>
		{
			new InlineArrayBuilder<InlineArray2_InlineArray2_NumberPair, InlineArray2_NumberPair>
			{
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					default(NumberPair),
					new NumberPair
					{
						lo = -6.123233995736766E-17,
						hi = -Math.PI / 2.0
					}
				},
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					new NumberPair
					{
						lo = -0.0,
						hi = -0.0
					},
					new NumberPair
					{
						lo = -6.123233995736766E-17,
						hi = -Math.PI / 2.0
					}
				}
			},
			new InlineArrayBuilder<InlineArray2_InlineArray2_NumberPair, InlineArray2_NumberPair>
			{
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					new NumberPair
					{
						lo = -1.2246467991473532E-16,
						hi = -Math.PI
					},
					new NumberPair
					{
						lo = 6.123233995736766E-17,
						hi = Math.PI / 2.0
					}
				},
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					new NumberPair
					{
						lo = -1.2246467991473532E-16,
						hi = -Math.PI
					},
					new NumberPair
					{
						lo = 6.123233995736766E-17,
						hi = Math.PI / 2.0
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
