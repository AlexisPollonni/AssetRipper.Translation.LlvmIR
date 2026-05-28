using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const.atan2.EXCEPTS")]
[DemangledName("__const.atan2.EXCEPTS")]
[CleanName("EXCEPTS")]
internal static partial class EXCEPTS_t7bjdm
{
	[FixedAddressValueType]
	private static InlineArray3_InlineArray3_InlineArray2_NumberPair __value;

	public unsafe static InlineArray3_InlineArray3_InlineArray2_NumberPair* Pointer => unchecked((InlineArray3_InlineArray3_InlineArray2_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray3_InlineArray3_InlineArray2_NumberPair Value
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

	unsafe static EXCEPTS_t7bjdm()
	{
		Value = new InlineArrayBuilder<InlineArray3_InlineArray3_InlineArray2_NumberPair, InlineArray3_InlineArray2_NumberPair>
		{
			new InlineArrayBuilder<InlineArray3_InlineArray2_NumberPair, InlineArray2_NumberPair>
			{
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					default(NumberPair),
					new NumberPair
					{
						Lo = 1.2246467991473532E-16,
						Hi = Math.PI
					}
				},
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					default(NumberPair),
					new NumberPair
					{
						Lo = 1.2246467991473532E-16,
						Hi = Math.PI
					}
				},
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					default(NumberPair),
					new NumberPair
					{
						Lo = 1.2246467991473532E-16,
						Hi = Math.PI
					}
				}
			},
			new InlineArrayBuilder<InlineArray3_InlineArray2_NumberPair, InlineArray2_NumberPair>
			{
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					new NumberPair
					{
						Lo = 6.123233995736766E-17,
						Hi = Math.PI / 2.0
					},
					new NumberPair
					{
						Lo = 6.123233995736766E-17,
						Hi = Math.PI / 2.0
					}
				},
				default(InlineArray2_NumberPair),
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					default(NumberPair),
					new NumberPair
					{
						Lo = 1.2246467991473532E-16,
						Hi = Math.PI
					}
				}
			},
			new InlineArrayBuilder<InlineArray3_InlineArray2_NumberPair, InlineArray2_NumberPair>
			{
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					new NumberPair
					{
						Lo = 6.123233995736766E-17,
						Hi = Math.PI / 2.0
					},
					new NumberPair
					{
						Lo = 6.123233995736766E-17,
						Hi = Math.PI / 2.0
					}
				},
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					new NumberPair
					{
						Lo = 6.123233995736766E-17,
						Hi = Math.PI / 2.0
					},
					new NumberPair
					{
						Lo = 6.123233995736766E-17,
						Hi = Math.PI / 2.0
					}
				},
				new InlineArrayBuilder<InlineArray2_NumberPair, NumberPair>
				{
					new NumberPair
					{
						Lo = 3.061616997868383E-17,
						Hi = Math.PI / 4.0
					},
					new NumberPair
					{
						Lo = 9.184850993605148E-17,
						Hi = Math.PI * 3.0 / 4.0
					}
				}
			}
		};
		_ = Pointer;
	}
}
