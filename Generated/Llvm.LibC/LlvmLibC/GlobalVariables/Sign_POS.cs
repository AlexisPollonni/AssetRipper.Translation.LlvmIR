using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_4Sign3POSE")]
[DemangledName("__llvm_libc_20_1_2_::Sign::POS")]
internal static partial class Sign_POS
{
	[FixedAddressValueType]
	private static Anon_izyfb7 __value;

	public unsafe static Anon_izyfb7* Pointer => unchecked((Anon_izyfb7*)Unsafe.AsPointer(ref __value));

	public static Anon_izyfb7 Value
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

	unsafe static Sign_POS()
	{
		_ = Pointer;
	}
}
