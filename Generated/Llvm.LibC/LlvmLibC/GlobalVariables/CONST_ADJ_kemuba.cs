using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const.atan2f.CONST_ADJ")]
[DemangledName("__const.atan2f.CONST_ADJ")]
[CleanName("CONST_ADJ")]
internal static partial class CONST_ADJ_kemuba
{
	[FixedAddressValueType]
	private static InlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair __value;

	public unsafe static InlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair* Pointer => unchecked((InlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair Value
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

	unsafe static CONST_ADJ_kemuba()
	{
		Value = new InlineArrayBuilder<InlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair, InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair>
		{
			new InlineArrayBuilder<InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair, InlineArray2_Llvm_libc_20_1_2_NumberPair>
			{
				new InlineArrayBuilder<InlineArray2_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
				{
					default(Llvm_libc_20_1_2_NumberPair),
					new Llvm_libc_20_1_2_NumberPair
					{
						Lo = -6.123233995736766E-17,
						Hi = -Math.PI / 2.0
					}
				},
				new InlineArrayBuilder<InlineArray2_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
				{
					new Llvm_libc_20_1_2_NumberPair
					{
						Lo = -0.0,
						Hi = -0.0
					},
					new Llvm_libc_20_1_2_NumberPair
					{
						Lo = -6.123233995736766E-17,
						Hi = -Math.PI / 2.0
					}
				}
			},
			new InlineArrayBuilder<InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair, InlineArray2_Llvm_libc_20_1_2_NumberPair>
			{
				new InlineArrayBuilder<InlineArray2_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
				{
					new Llvm_libc_20_1_2_NumberPair
					{
						Lo = -1.2246467991473532E-16,
						Hi = -Math.PI
					},
					new Llvm_libc_20_1_2_NumberPair
					{
						Lo = 6.123233995736766E-17,
						Hi = Math.PI / 2.0
					}
				},
				new InlineArrayBuilder<InlineArray2_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
				{
					new Llvm_libc_20_1_2_NumberPair
					{
						Lo = -1.2246467991473532E-16,
						Hi = -Math.PI
					},
					new Llvm_libc_20_1_2_NumberPair
					{
						Lo = 6.123233995736766E-17,
						Hi = Math.PI / 2.0
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
