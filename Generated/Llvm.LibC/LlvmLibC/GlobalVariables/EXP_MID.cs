using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L7EXP_MIDE")]
[DemangledName("__llvm_libc_20_1_2_::EXP_MID")]
internal static partial class EXP_MID
{
	[FixedAddressValueType]
	private static Cpp_array_dsir8b __value;

	public unsafe static Cpp_array_dsir8b* Pointer => unchecked((Cpp_array_dsir8b*)Unsafe.AsPointer(ref __value));

	public static Cpp_array_dsir8b Value
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

	unsafe static EXP_MID()
	{
		Value = new Cpp_array_dsir8b
		{
			Data = InlineArrayHelper.Create<InlineArray8_Single, float>(new float[8] { 1f, 1.1331484f, 1.2840254f, 1.4549915f, 1.6487212f, 1.868246f, 2.117f, 2.3988752f })
		};
		_ = Pointer;
	}
}
