using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_1RE")]
[DemangledName("__llvm_libc_20_1_2_::R")]
internal static partial class R
{
	[FixedAddressValueType]
	private static InlineArray128_Single __value;

	public unsafe static InlineArray128_Single* Pointer => unchecked((InlineArray128_Single*)Unsafe.AsPointer(ref __value));

	public static InlineArray128_Single Value
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

	unsafe static R()
	{
		Value = InlineArrayHelper.Create<InlineArray128_Single, float>(new float[128]
		{
			1f,
			127f / 128f,
			63f / 64f,
			125f / 128f,
			31f / 32f,
			123f / 128f,
			61f / 64f,
			121f / 128f,
			0.9375f,
			0.93359375f,
			0.92578125f,
			0.91796875f,
			117f / 128f,
			29f / 32f,
			115f / 128f,
			0.89453125f,
			0.88671875f,
			113f / 128f,
			0.875f,
			0.87109375f,
			0.86328125f,
			55f / 64f,
			109f / 128f,
			0.84765625f,
			0.83984375f,
			107f / 128f,
			53f / 64f,
			0.82421875f,
			105f / 128f,
			0.8125f,
			0.80859375f,
			103f / 128f,
			51f / 64f,
			0.79296875f,
			101f / 128f,
			0.78515625f,
			25f / 32f,
			99f / 128f,
			0.76953125f,
			49f / 64f,
			0.76171875f,
			97f / 128f,
			0.75f,
			0.74609375f,
			95f / 128f,
			0.73828125f,
			47f / 64f,
			0.73046875f,
			93f / 128f,
			0.72265625f,
			23f / 32f,
			0.71484375f,
			91f / 128f,
			0.70703125f,
			45f / 64f,
			0.69921875f,
			89f / 128f,
			0.69140625f,
			0.6875f,
			0.68359375f,
			87f / 128f,
			0.67578125f,
			43f / 64f,
			0.66796875f,
			85f / 128f,
			85f / 128f,
			0.66015625f,
			21f / 32f,
			0.65234375f,
			83f / 128f,
			0.64453125f,
			0.64453125f,
			41f / 64f,
			0.63671875f,
			81f / 128f,
			0.62890625f,
			0.625f,
			0.625f,
			0.62109375f,
			79f / 128f,
			0.61328125f,
			0.61328125f,
			39f / 64f,
			0.60546875f,
			77f / 128f,
			77f / 128f,
			0.59765625f,
			19f / 32f,
			19f / 32f,
			0.58984375f,
			75f / 128f,
			75f / 128f,
			0.58203125f,
			37f / 64f,
			37f / 64f,
			0.57421875f,
			73f / 128f,
			73f / 128f,
			0.56640625f,
			0.5625f,
			0.5625f,
			0.55859375f,
			71f / 128f,
			71f / 128f,
			0.55078125f,
			0.55078125f,
			35f / 64f,
			0.54296875f,
			0.54296875f,
			69f / 128f,
			69f / 128f,
			0.53515625f,
			17f / 32f,
			17f / 32f,
			0.52734375f,
			0.52734375f,
			67f / 128f,
			67f / 128f,
			0.51953125f,
			0.51953125f,
			33f / 64f,
			33f / 64f,
			0.51171875f,
			0.51171875f,
			65f / 128f,
			65f / 128f,
			0.50390625f,
			0.5f
		});
		PointerIndices.Register(Pointer);
	}
}
