using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L18EXCEPT_OUTPUTS_COSE")]
[DemangledName("__llvm_libc_20_1_2_::EXCEPT_OUTPUTS_COS")]
internal static partial class EXCEPT_OUTPUTS_COS
{
	[FixedAddressValueType]
	private static InlineArray6_InlineArray4_Int32 __value;

	public unsafe static InlineArray6_InlineArray4_Int32* Pointer => unchecked((InlineArray6_InlineArray4_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray6_InlineArray4_Int32 Value
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

	unsafe static EXCEPT_OUTPUTS_COS()
	{
		Value = new InlineArrayBuilder<InlineArray6_InlineArray4_Int32, InlineArray4_Int32>
		{
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { -1083176693, 0, 1, 0 }),
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { 1062118866, 1, 0, 0 }),
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { 1057533630, 1, 0, 1 }),
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { 1065292987, 1, 0, 0 }),
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { 1064834094, 1, 0, 1 }),
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { 1057530396, 1, 0, 0 })
		};
		PointerIndices.Register(Pointer);
	}
}
