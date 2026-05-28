using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L16SIN_K_PI_OVER_32E")]
[DemangledName("__llvm_libc_20_1_2_::SIN_K_PI_OVER_32")]
internal static partial class SIN_K_PI_OVER_32
{
	[FixedAddressValueType]
	private static InlineArray64_Single __value;

	public unsafe static InlineArray64_Single* Pointer => unchecked((InlineArray64_Single*)Unsafe.AsPointer(ref __value));

	public static InlineArray64_Single Value
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

	unsafe static SIN_K_PI_OVER_32()
	{
		Value = InlineArrayHelper.Create<InlineArray64_Single, float>(new float[64]
		{
			0f, 0.09801714f, 0.19509032f, 0.29028466f, 0.38268343f, 0.47139674f, 0.55557024f, 0.6343933f, 0.70710677f, 0.77301043f,
			0.8314696f, 0.8819213f, 0.9238795f, 0.95694035f, 0.98078525f, 0.9951847f, 1f, 0.9951847f, 0.98078525f, 0.95694035f,
			0.9238795f, 0.8819213f, 0.8314696f, 0.77301043f, 0.70710677f, 0.6343933f, 0.55557024f, 0.47139674f, 0.38268343f, 0.29028466f,
			0.19509032f, 0.09801714f, 0f, -0.09801714f, -0.19509032f, -0.29028466f, -0.38268343f, -0.47139674f, -0.55557024f, -0.6343933f,
			-0.70710677f, -0.77301043f, -0.8314696f, -0.8819213f, -0.9238795f, -0.95694035f, -0.9807853f, -0.9951847f, -1f, -0.9951847f,
			-0.98078525f, -0.95694035f, -0.9238795f, -0.8819213f, -0.8314696f, -0.77301043f, -0.70710677f, -0.6343933f, -0.55557024f, -0.47139674f,
			-0.38268343f, -0.29028466f, -0.19509032f, -0.09801714f
		});
		_ = Pointer;
	}
}
