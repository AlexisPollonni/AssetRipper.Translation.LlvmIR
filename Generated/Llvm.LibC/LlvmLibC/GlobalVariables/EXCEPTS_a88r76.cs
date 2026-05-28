using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const.atan2f.EXCEPTS")]
[DemangledName("__const.atan2f.EXCEPTS")]
[CleanName("EXCEPTS")]
internal static partial class EXCEPTS_a88r76
{
	[FixedAddressValueType]
	private static InlineArray3_InlineArray3_InlineArray2_Double __value;

	public unsafe static InlineArray3_InlineArray3_InlineArray2_Double* Pointer => unchecked((InlineArray3_InlineArray3_InlineArray2_Double*)Unsafe.AsPointer(ref __value));

	public static InlineArray3_InlineArray3_InlineArray2_Double Value
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

	unsafe static EXCEPTS_a88r76()
	{
		Value = new InlineArrayBuilder<InlineArray3_InlineArray3_InlineArray2_Double, InlineArray3_InlineArray2_Double>
		{
			new InlineArrayBuilder<InlineArray3_InlineArray2_Double, InlineArray2_Double>
			{
				InlineArrayHelper.Create<InlineArray2_Double, double>(new double[2]
				{
					0.0,
					Math.PI
				}),
				InlineArrayHelper.Create<InlineArray2_Double, double>(new double[2]
				{
					0.0,
					Math.PI
				}),
				InlineArrayHelper.Create<InlineArray2_Double, double>(new double[2]
				{
					0.0,
					Math.PI
				})
			},
			new InlineArrayBuilder<InlineArray3_InlineArray2_Double, InlineArray2_Double>
			{
				InlineArrayHelper.Create<InlineArray2_Double, double>(new double[2]
				{
					Math.PI / 2.0,
					Math.PI / 2.0
				}),
				default(InlineArray2_Double),
				InlineArrayHelper.Create<InlineArray2_Double, double>(new double[2]
				{
					0.0,
					Math.PI
				})
			},
			new InlineArrayBuilder<InlineArray3_InlineArray2_Double, InlineArray2_Double>
			{
				InlineArrayHelper.Create<InlineArray2_Double, double>(new double[2]
				{
					Math.PI / 2.0,
					Math.PI / 2.0
				}),
				InlineArrayHelper.Create<InlineArray2_Double, double>(new double[2]
				{
					Math.PI / 2.0,
					Math.PI / 2.0
				}),
				InlineArrayHelper.Create<InlineArray2_Double, double>(new double[2]
				{
					Math.PI / 4.0,
					Math.PI * 3.0 / 4.0
				})
			}
		};
		_ = Pointer;
	}
}
