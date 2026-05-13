using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_10libc_errnoE")]
[DemangledName("__llvm_libc_20_1_2_::libc_errno")]
internal static partial class libc_errno
{
	[FixedAddressValueType]
	private static anon_izyfb7 __value;

	public unsafe static anon_izyfb7* Pointer => unchecked((anon_izyfb7*)Unsafe.AsPointer(ref __value));

	public static anon_izyfb7 Value
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

	unsafe static libc_errno()
	{
		PointerIndices.Register(Pointer);
	}
}
